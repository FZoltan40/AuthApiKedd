namespace AuthApi.Models.Dtos
{
    public record CreateUserDto(string UserName, string Email, string Password, DateTime BirthDate, string PhoneNumber);

    public record LoginIUserDto(string UserName, string Password);
}
