namespace Library.UnitTests.Infrastructure.JsonLoanRepository;

using Library.Infrastructure.Data;
using Microsoft.Extensions.Configuration;

public class GetLoanTest
{
    private readonly ILoanRepository _mockLoanRepository;
    private readonly JsonLoanRepository _jsonLoanRepository;
    private readonly IConfiguration _configuration;
    private readonly JsonData _jsonData;

    public GetLoanTest()
    {
        _mockLoanRepository = Substitute.For<ILoanRepository>();
         _configuration = new ConfigurationBuilder().Build();
         _jsonData = new JsonData(_configuration);
         _jsonLoanRepository = new JsonLoanRepository(_jsonData);  
    }
}
