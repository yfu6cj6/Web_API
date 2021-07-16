using DapperTest.Define;
using DapperTest.Model;
using Microsoft.AspNetCore.Mvc;

namespace DapperTest.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DapperController : ControllerBase
    {
        private readonly IService _service;

        public DapperController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        public object GetDB()
        {
            return _service.GetDB();
        }

        [HttpGet("{id}")]
        public object GetDB(int id)
        {
            return _service.GetDB(id);
        }

        /// <summary>
        /// Creates a TodoItem.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "name": "Item1",
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        public object PostDB([FromBody] UserModel model)
        {
            return _service.PostDB(model);
        }

        [HttpPut]
        public object PutDB([FromBody] UserModel model)
        {
            return _service.PutDB(model);
        }

        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        [HttpDelete("{id}")]
        public object DeleteDB(int id)
        {
            return _service.DeleteDB(id);
        }
    }
}
