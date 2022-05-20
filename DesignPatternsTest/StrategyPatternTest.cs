using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsImplementation.StrategyPattern;
using Moq;
using Xunit;

namespace DesignPatternsTest
{
    public class StrategyPatternTest
    {
        private readonly IPhotoShare _photoShare;
        
        public StrategyPatternTest()
        {
            _photoShare = new PhotoShareBySocialMedia();
        }
        
        [Fact]
        public void Use_Photo_Share_By_Email()
        {
            var cameraPlusApp = new CameraPlusApp(_photoShare);
            cameraPlusApp.Save();
            // Assert.True(true);
        }
    }
}