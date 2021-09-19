using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class RepositoryDB
    {
        private const string ConnectionString = "AccountEndpoint=https://exercise1309.documents.azure.com:443/;AccountKey=V1qnssMvexKoeewlzL0BX2V3RZPioaPmIuWKnDIamEn9BoZrUpLM1renSfuSt4te0fYHm34W7Qw8H2LeRQtbqw==;";

        private const string Database = "AT-Azure";

        private const string Container = "id";

        private CosmosClient CosmosClient { get; set; }

        public RepositoryDB()
        {
            CosmosClient = new CosmosClient(ConnectionString);
        }

        public List<Tarefa> GetAll()
        {
            var container = this.CosmosClient.GetContainer(Database, Container);

            QueryDefinition queryDefinition = new QueryDefinition("SELECT * FROM c");

            var tarefas = new List<Tarefa>();

            var queryResult = container.GetItemQueryIterator<Tarefa>(queryDefinition);

            while (queryResult.HasMoreResults)
            {
                FeedResponse<Tarefa> currentResultSet = queryResult.ReadNextAsync().Result;
                tarefas.AddRange(currentResultSet.Resource);
            }

            return tarefas;

        }

        public Tarefa GetById(string id)
        {
            var container = this.CosmosClient.GetContainer(Database, Container);

            QueryDefinition queryDefinition = new QueryDefinition($"SELECT * FROM c where c.id = '{id}'");

            var queryResult = container.GetItemQueryIterator<Tarefa>(queryDefinition);

            Tarefa tar = null;

            while (queryResult.HasMoreResults)
            {
                FeedResponse<Tarefa> currentResultSet = queryResult.ReadNextAsync().Result;
                tar = currentResultSet.Resource.FirstOrDefault();
            }

            return tar;
        }

        public async Task Save(Tarefa tarefa)
        {
            var container = this.CosmosClient.GetContainer(Database, Container);
            await container.CreateItemAsync(tarefa, new PartitionKey(tarefa.ToDo));
        }

        public async Task Update(Tarefa tar)
        {
            var container = this.CosmosClient.GetContainer(Database, Container);
            await container.ReplaceItemAsync<Tarefa>(tar, tar.Id.ToString(), new PartitionKey(tar.ToDo));
        }

        public async Task Delete(Tarefa tarefa)
        {
            var container = this.CosmosClient.GetContainer(Database, Container);
            await container.DeleteItemAsync<Tarefa>(tarefa.Id.ToString(), new PartitionKey(tarefa.ToDo));          
        }

    }
}
