using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusineesLayer.Map;
using AutoMapper;

namespace BusineesLayer.Managers
{
    public class TopicManager: DataFactory<DataBaseCTX,TopicsInCourse>
    {
        DataBaseCTX ctx = new DataBaseCTX();
        Course cr = new Course() {CourseID=874 };

        public List<TopicsInCourseMap> GetAllTopics(int CrsId)
        {
             var TopicList = new TopicManager().FindListBy(x => x.Crs_Id == CrsId);
            //List<TopicsInCourse> TopicList = (from i in ctx.TopicsInCourses
            //                                  where i.Crs_Id == CrsId
            //                                  select i).ToList();
            var t = Mapper.Map<List<TopicsInCourseMap>>(TopicList);
            return t;
        }
        public bool EditTopic (TopicsInCourse t)
        {
            var top = new TopicManager().Update(t);
            return true;
        }
        public bool DeleteTopic (int CrsId)
        {
            var top = new TopicManager().Delete(CrsId);
            return true;
        }
        public TopicsInCourse AddTopic (TopicsInCourse t)
        {
            var top = new TopicManager().Add(t);
            return top;
        }
    }
}
