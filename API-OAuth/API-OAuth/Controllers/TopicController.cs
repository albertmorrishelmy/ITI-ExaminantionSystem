using BusineesLayer.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using DataAccessLayer.Models;
using BusineesLayer.Map;

namespace API_OAuth.Controllers
{
    public class TopicController : ApiController
    {
        TopicManager TopMangr = new TopicManager();
        [System.Web.Http.HttpGet]
        public List<TopicsInCourseMap> AllCrsTopics(int CrsId)
        {
            return TopMangr.GetAllTopics(CrsId);
        }
        public bool EditCrs(TopicsInCourse t)
        {
            return TopMangr.EditTopic(t);
        }
        public bool DeleteTpc(int topdid)
        {
            return TopMangr.DeleteTopic(topdid);
        }
    }
}