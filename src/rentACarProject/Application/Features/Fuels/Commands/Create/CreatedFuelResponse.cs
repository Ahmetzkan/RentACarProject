using NArchitecture.Core.Application.Responses;

namespace Application.Features.Fuels.Commands.Create;

public class CreatedFuelResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}