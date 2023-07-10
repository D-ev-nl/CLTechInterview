using Services.DTOs;

namespace Services.Interfacces
{
    public interface IServiceInterface<TDTO, TItemDTO, TGridItemDTO, TId>
        where TId : struct
        where TDTO : class
        where TItemDTO : class
        where TGridItemDTO : class
    {
        Task<TDTO> Get(TId id);
        Task<List<TItemDTO>> ListAll();
        Task<List<TGridItemDTO>> GetAll();

        Task<bool> Exists(TId id);
        Task<(bool Valid, string Message)> Validate(TId? id, TDTO dto);

        Task<TDTO> Create(TDTO dto);
        Task<TDTO> Update(TId id, TDTO dto);
        Task Delete(TId id);
    }
}
