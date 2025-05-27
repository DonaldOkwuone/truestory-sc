using Truestory.model;
using Truestory.model.dto;

namespace Truestory.Mappers
{
    public static class CreateGadgetMapper
    {
        public static Gadget MapMessage(AddGadgetDto messageDto)
        {

            return new Gadget
            {
                name = messageDto.name,
                data = new Data
                {
                    price = messageDto.price,
                    CPUmodel = messageDto.CPUmodel,
                    Harddisksize = messageDto.Harddisksize,
                    year = messageDto.year,
                },
                createdAt = DateTime.Now
            };
        }
    }
}
