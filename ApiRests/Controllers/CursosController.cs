﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiRests.Models;

namespace ApiRests.Controllers
{
    public class CursosController : ApiController
    {
        private cursoEntities db;

        public CursosController()
        {
            db = new cursoEntities();
        }

        public IQueryable<Curso> Get()
        {
            return db.Curso;
        }

        [ResponseType(typeof(Curso))]
        public IHttpActionResult GetPorId(int id)
        {
            var data = db.Curso.Find(id);
            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }
    }
}
