using EsVideo.Database;
using EsVideo.Model.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsVideo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IUserController : ControllerBase
    {
        /*private static FakeDatabase database = new FakeDatabase();

        //Get prevedono la restituzione di un informazione
        [HttpGet] 
        //api/IUser/GetData
        public IActionResult GetData()
        {
            return Ok("Test");
        }
        [HttpGet("All")] //DIfferenziare le due rotte Get
        public IActionResult AllUsers()
        {
            return Ok(database.Users);
        }
        //Rotta che restituisce l'urente tramite l'id passato in input
        [HttpGet] 
        public IActionResult GetUser(int IdUser)
        {
            var user = database.Users.FirstOrDefault(x => x.IdUSer == IdUser);
            if (user == null)
                return NotFound();
            return Ok(user);
        }
        //Implementare rotta delete
        [HttpDelete]
        public IActionResult DeleteUser(int IdUser)
        {
            var user = database.Users.FirstOrDefault(x => x.IdUSer == IdUser);
            if (user == null)
                return NotFound();
            database.Users.Remove(user);
            return Ok(); //Restituisce 200
        }
        
        //Inserimento di un nuovo utente tramite post, i dati imposti devono essere passati nel body della richiesta
        [HttpPost]
        public IActionResult AddUser([FromBody] AddUserRequest request)
        {
            database.AddUser(new Database.User { IdUSer=0, Username=request.Username, Password=request.Password, Name=request.Name, Surname=request.Surname});
            return Ok();
        }

        //Modifica di un utente tramite put, i dati imposti devono essere passati nel body della richiesta, non richiedono dati nel QueryString
        [HttpPut]
        public IActionResult UpdateUser([FromBody] UpdateUserRequest request)
        {
            var user = database.Users.FirstOrDefault(x => x.IdUSer == request.IdUser);
            if (user == null)
                return NotFound();
            user.Username = request.Username;
            user.Password = request.Password;
            user.Name = request.Name; 
            user.Surname = request.Surname;
            return Ok();
        }
        */
       
    }
}
