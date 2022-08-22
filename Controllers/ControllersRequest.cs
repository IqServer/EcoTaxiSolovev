using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace ControllersRequest;

[ApiController]
[Route("api/[controller]/[action]")]
public class RequestController : ControllerBase
{
    RequestServices _requestService;
    public RequestController(RequestServices requestService) 
    {
        _requestService = requestService;
    }
    [HttpGet("Request")]

    public List<Request> GetAll()
    {

         return _requestService.GetRequest();
    }
  
    [HttpGet("GetRequestById")]
    public Request GetRequestById(int id)
    {
        return _requestService.GetRequestById(id);
    }

    [HttpPost("Add")]
    public void Add([FromBody] Request newRequest)
    {
        _requestService.AddRequest(newRequest);
    }

    [HttpGet("Default")]
    public  void Default(int id)
    {
     _requestService.Default();

    }

}