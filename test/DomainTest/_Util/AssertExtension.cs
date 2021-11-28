using System;
using Xunit;

namespace DomainTest._Util
{
    public static class AssertExtension
    {
        public static void ComMessagem(this ArgumentException exception, string mensagem)
        {
            if (exception.Message == mensagem)
                Assert.True(true);
            else
                Assert.False(true);
        }
    }
}
