using Model;
using Stub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketBookVincentAstolfi.Stub
{
    public class PocketBookStub : ILibManager
    {
        private StubDTO.Stub StubDTO { get; set; } = new StubDTO.Stub();
        public PocketBookStub()
        {
        }

        public async Task<List<Book>> GetBooks()
        {
            return (List<Book>)(await StubDTO.GetBooks()).ToPocos();
        }
    }
}
