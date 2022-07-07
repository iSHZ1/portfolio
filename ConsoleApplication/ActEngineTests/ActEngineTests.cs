using ActManager;
using Xunit;

namespace ActManagerTests
{
    public class ActEngineTests
    {
        [Fact]
        public void EngineWorks()
        {
            var engine = new ActEngine();
            engine.CreateAct();
        }
    }
}