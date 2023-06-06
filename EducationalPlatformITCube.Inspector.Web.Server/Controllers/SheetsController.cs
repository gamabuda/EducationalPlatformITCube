using EducationalPlatformITCube.Inspector.Web.Server.Pages.Classes;
using Google.Apis.Sheets.v4;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationalPlatformITCube.Inspector.Web.Server.Controllers
{
    [Route("api/Requests")]
    [ApiController]
    public class SheetsController : ControllerBase
    {
        const string SPREADSHEET_ID = "1g1GtZIwstLrQKHOi5CE41hp1OByy9QgnFZoCvknMWn0";
        const string SHEET_NAME = "Answers";
        private readonly SpreadsheetsResource.ValuesResource _googleSheetValues;
        public SheetsController(GoogleSheetsHelper googleSheetsHelper)
        {
            _googleSheetValues = googleSheetsHelper.Service.Spreadsheets.Values;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var range = $"{SHEET_NAME}!A:T";
            var request = _googleSheetValues.Get(SPREADSHEET_ID, range);
            var response = request.Execute();
            var values = response.Values;
            return Ok(ItemsMapper.MapFromRangeData(values));
        }
    }
}
