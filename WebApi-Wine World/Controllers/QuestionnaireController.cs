using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi_Wine_World.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]

    public class QuestionnaireController : ApiController
    {
        QuestionnaireService questionnaireService = new QuestionnaireService();

        // GET: api/Questionnaire
        public List<QuestionnaireDto> Get()
        {
            return questionnaireService.GetQuestionnire();
        }

    }
}
