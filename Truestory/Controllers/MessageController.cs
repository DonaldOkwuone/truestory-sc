using Microsoft.AspNetCore.Mvc;
using Truestory.model.dto;
using Truestory.model.pagination;
using Truestory.Services;

namespace Truestory.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        public IGadgetService _messageService { get; set; }
        public MessageController(IGadgetService messageService)
        {
            _messageService = messageService;
        }
        [Route("addMessage")]
        [HttpPost]
        public async Task<IActionResult> AddMessage([FromBody] AddGadgetDto addMessageDto)
        {
            var createdMessage = await _messageService.AddMessage(addMessageDto);
            if (createdMessage.IsSuccess == false)
            {
                return BadRequest(createdMessage);
            }
            return Ok(createdMessage);
        }
        [HttpGet]
        [Route("FetchRecords")]
        public IActionResult FetchRecords([FromQuery] GadgetRequestParam messageRequest)
        {
            var pagedResp = _messageService.GetMessage(messageRequest);
            if (pagedResp.IsSuccess == false) { return BadRequest(pagedResp); }
            return Ok(pagedResp);
        }

        [HttpDelete]
        [Route("DeleteRecords")]
        public async Task<IActionResult> DeleteRecords(DeleteGadgetRequestDto deleteReq)
        {
            var DeleteResp = await _messageService.RemoveMessage(deleteReq);
            if (DeleteResp.IsSuccess == false)
            {
                return BadRequest(DeleteResp);
            }

            return Ok(DeleteResp);
        }
    }
}
