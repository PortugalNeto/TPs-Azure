﻿using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amigos.API.Controllers
{
    [Route("api/amigos")]
    [ApiController]
    public class AmigosController : ControllerBase
    {
        public AmigosController(AmigosRepositorio amigosRepositorio)
        {
            dataBase = amigosRepositorio;
        }

        private AmigosRepositorio dataBase;

        [HttpPost]
        public ActionResult Post([FromBody] CadastrarAmigoRequest amigo)
        {
            dataBase.Create(amigo.Nome, amigo.Sobrenome, amigo.Email, amigo.Telefone, amigo.Aniversario);
            return Ok(amigo);
        }

        [HttpDelete]
        public ActionResult Delete([FromQuery] int id)
        {
            dataBase.Delete(id);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update([FromQuery] int id, [FromBody] CadastrarAmigoRequest amigo)
        {
            dataBase.Update(id, amigo.Nome, amigo.Sobrenome, amigo.Email, amigo.Telefone, amigo.Aniversario);
            return Ok();
        }

        [HttpGet]
        public ActionResult Get([FromQuery] int id)
        {
            if(id != 0)
            {
            var amigo = dataBase.GetById(id);
            return Ok(amigo);
            }
            else
            {
                var amigos = dataBase.GetAll();
                return Ok(amigos);
            }
        }
    }
}
