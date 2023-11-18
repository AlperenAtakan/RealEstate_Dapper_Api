using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.WhoWeAreDetailDtos;
using RealEstate_Dapper_Api.Repositories.WhoWeAreRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreRepository _whoWeAreDetailRepository;
        public WhoWeAreDetailController(IWhoWeAreRepository whoWeAreDetailRepository)
        {
            _whoWeAreDetailRepository = whoWeAreDetailRepository;
        }

        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoWeAreDetailRepository.GetAllWhoWeAreDetailAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            _whoWeAreDetailRepository.CreateWhoWeAreDetailAsync(createWhoWeAreDetailDto);
            return Ok("Hakkımızda Kısmı Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            _whoWeAreDetailRepository.DeleteWhoWeAreDetailAsync(id);
            return Ok("Hakkımızda Kısmı Başarılı Bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            _whoWeAreDetailRepository.UpdateWhoWeAreDetailAsync(updateWhoWeAreDetailDto);
            return Ok("Hakkımızda Kısmı Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAreDetail(int id)
        {
            var value = await _whoWeAreDetailRepository.GetWhoWeAreDetail(id);
            return Ok(value);
        }

    }
}
