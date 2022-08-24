using Microsoft.AspNetCore.Mvc;
using Freebob;
using Services;

namespace Freebob;

public class DefaultDataController : ControllerBase
{
    private ILogger<DefaultDataController> _logger;
    private CarServices _carServices;
    private OperatorServices _operatorServices;
    private OrderServices _orderServices;
    private RequestServices _requestServices;
    private UserServices _userServices;
    private PointServices _pointServices;
    DataContext _context;
    public DefaultDataController(ILogger<DefaultDataController> logger,
        CarServices carServices,
        OperatorServices operatorServices,
        OrderServices orderServices,
        RequestServices requestServices,
        UserServices userServices,
        PointServices pointServices,
        DataContext context
        )
        {
             _logger = logger;
        _carServices = carServices;
        _operatorServices = operatorServices;
        _orderServices = orderServices;
        _requestServices = requestServices;
        _userServices = userServices;
        _pointServices = pointServices;
        _context = context;
        }
     
      

    [HttpPost("DefaultAllData")]
    public void DefaultAllData()
    {
        _logger.Log(LogLevel.Warning, "Выполняется создание данных по умолчанию...");
        _carServices.Default();
        _operatorServices.Default();
        _orderServices.Default();
        _requestServices.Default();
        _userServices.Default();
        _pointServices.Default();
    }

    [HttpGet("CreateDB")]
    public void CreateDB()
    {
        _context.CreateBDNew();
    }
}