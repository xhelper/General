using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GeneralApi.Controllers {
    /// <summary>
    /// 时候用
    /// </summary>
    [Route ("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        /// <summary>
        /// 测试用例
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get () {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// GET api/values/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet ("{id}")]
        public ActionResult<string> Get (int id) {
            return "value";
        }

        /// <summary>
        /// POST api/values
        /// </summary>
        /// <param name="value">值</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<string> Post ([FromBody] string value) {
            return value;
        }

        /// <summary>
        /// PUT api/values/5
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="value">值</param>
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        /// <summary>
        /// DELETE api/values/5
        /// </summary>
        /// <param name="id">编号</param>
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}