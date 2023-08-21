using Blazor.Models.Catan;

namespace Blazor.Services.Catan
{
    public interface ICatanBoardBuilder
    {
        Task<Board> Random();
    }
}
