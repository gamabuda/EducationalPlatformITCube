namespace EducationalPlatformITCube.Inspector.Web.Server.Pages.Classes
{
    public class ItemsMapper
    {
        public static List<RequestModel> MapFromRangeData(IList<IList<object>> values)
        {
            var items = new List<RequestModel>();
            foreach (var value in values)
            {
                RequestModel item = new()
                {
                    Date = value[0].ToString(),
                    Email = value[1].ToString(),
                    ChildLastName = value[2].ToString(),
                    ChildFirstName = value[3].ToString(),
                    ChildMiddleName = value[4].ToString(),
                    ChildBirthDate = value[5].ToString(),
                    Age = value[6].ToString(),
                    SchoolNumber = value[7].ToString(),
                    Grade = value[8].ToString(),
                    StudyShift = value[9].ToString(),
                    CourseSelection = value[10].ToString(),
                    ParentLastName = value[11].ToString(),
                    ParentFirstName = value[12].ToString(),
                    ParentMiddleName = value[13].ToString(),
                    ParentPhoneNumber = value[14].ToString(),
                    ParentComment = value[15].ToString(),
                    //posInQuery = value[16].ToString(),
                    //AdminComment = value[20].ToString()
                };
                items.Add(item);
            }
            return items;
        }
        public static IList<IList<object>> MapToRangeData(RequestModel item)
        {
            var objectList = new List<object>() { item.Date, item.Email, item.ChildLastName, item.ChildFirstName, item.ChildMiddleName,
                                                    item.ChildBirthDate, item.Age, item.SchoolNumber, item.Grade, item.StudyShift,
                                                    item.CourseSelection, item.FormEducation, item.ParentLastName, item.ParentFirstName,
                                                    item.ParentMiddleName, item.ParentPhoneNumber, item.ParentComment, item.posInQuery, item.AdminComment};
            var rangeData = new List<IList<object>> { objectList };
            return rangeData;
        }
    }
}
