
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;


namespace RealEstate_Dapper_Api.Repositories.PopulerLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        void CreatePopularLocationAsync(CreatePopularLocationDto createPopularLocationDto);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIDPopularLocationDto> GetByIDPopularLocationAsync(int id);

    }
}
