using FluentValidation;
using Truestory.Mappers;
using Truestory.model;
using Truestory.model.dto;
using Truestory.model.pagination;
using Truestory.Repositories;

namespace Truestory.Services.Imlementations
{
    public class GadgetService : IGadgetService
    {
        private readonly IValidator<Gadget> _validator;
        private readonly IValidator<GadgetRequestParam> _fetchLaptopValidator;
        private readonly IGadgetRepo _laptopRepo;

        public GadgetService(IValidator<Gadget> validator, IValidator<GadgetRequestParam> fetchLaptopValidator, IGadgetRepo laptopRepo)
        {
            this._validator = validator;
            this._fetchLaptopValidator = fetchLaptopValidator;
            this._laptopRepo = laptopRepo;
        }


        public async Task<Result<Gadget>> AddMessage(AddGadgetDto addMessageDto)
        {
            //Validate
            Gadget msg = CreateGadgetMapper.MapMessage(addMessageDto);
            var validation = _validator.Validate(msg);
            if (validation.Errors.Count > 0)
            {
                return Result<Gadget>.Failure(validation.Errors[0].ErrorMessage);
            }

            _laptopRepo.AddLaptop(msg);

            return Result<Gadget>.Success(msg);
        }

        public Result<PageList<Gadget>> GetMessage(GadgetRequestParam name)
        {
            var validation = _fetchLaptopValidator.Validate(name);

            if (validation.Errors.Count > 0)
            {
                return Result<PageList<Gadget>>.Failure(validation.Errors[0].ErrorMessage);
            }
            var messages = _laptopRepo.GetAllLaptops().Where(x => x.name.ToLower().Contains(name.name.ToLower()));
            return Result<PageList<Gadget>>.Success(PageList<Gadget>.ToPagedList(messages.AsQueryable(), name.pageNum, name.pageSize));
        }

        public async Task<Result<DeleteGadgetRespDto>> RemoveMessage(DeleteGadgetRequestDto deleteReq)
        {
            if (string.IsNullOrEmpty(deleteReq.Id))
            {
                return Result<DeleteGadgetRespDto>.Failure("Please enter a valid Id");
            }
            var RecordToDelete = _laptopRepo.GetAllLaptops().Where(x => x.id == deleteReq.Id).FirstOrDefault();

            if (RecordToDelete is null)
            {
                return Result<DeleteGadgetRespDto>.Failure($"Laptop spec with {deleteReq.Id} not found");
            }

            _laptopRepo.Remove(RecordToDelete);
            return Result<DeleteGadgetRespDto>.Success(new DeleteGadgetRespDto { message = $"Object with id = {deleteReq.Id}, has been deleted." });
        }
    }
}
