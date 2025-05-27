using System.Threading.Tasks;
using Truestory.model;
using Truestory.model.dto;
using Truestory.model.pagination;

namespace Truestory.Services
{
    public interface IGadgetService
    {
        Result<PageList<Gadget>> GetMessage(GadgetRequestParam messageRequest);
        Task<Result<Gadget>> AddMessage(AddGadgetDto addMessageDto);
        Task<Result<DeleteGadgetRespDto>> RemoveMessage(DeleteGadgetRequestDto Id);
    }
}
