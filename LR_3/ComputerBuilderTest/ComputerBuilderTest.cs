using Moq;
using Xunit;
using ComputerLibrary;

namespace ComputerBuilderTest
{
    public class ComputerBuilderTest
    {
        [Fact]
        public void Director_ConstructGamingPC_InvokesBuilderMethods()
        {
            // Arrange
            var mockBuilder = new Mock<ICompBuilder>();
            var director = new Director();

            // Act
            director.ConstructGamingPC(mockBuilder.Object);

            // Assert
            mockBuilder.Verify(b => b.Reset(), Times.Once);
            mockBuilder.Verify(b => b.SetCPU(It.IsAny<CPU>()), Times.Once);
            mockBuilder.Verify(b => b.SetGPU(It.IsAny<GPU>()), Times.Once);
            mockBuilder.Verify(b => b.SetRAM(It.IsAny<RAM>()), Times.Once);
            mockBuilder.Verify(b => b.SetStorage(It.IsAny<Storage>()), Times.Once);
            mockBuilder.Verify(b => b.SetPowerSupply(It.IsAny<PowerSupply>()), Times.Once);
            mockBuilder.Verify(b => b.SetCoolingSystem(It.IsAny<Cooling>()), Times.Once);
        }


        [Fact]
        public void MockBuilder_CreatesExpectedComputer()
        {
            // Arrange
            var mockBuilder = new Mock<ICompBuilder>();
            var expectedComputer = new Computer
            {
                Name = "Mocked Computer",
                CPU = new CPU(CPUType.office, CPUManufacturer.Intel, CPULine.Core_i3_12100),
                GPU = new GPU(GPUType.office, GPUManufacturer.ASUS, GPULine.RTX_4090),
                RAM = new RAM(RAMType.DDR, RAMSize._4GB),
                Storage = new Storage(StorageType.SSD, StorageSize._1024),
                PowerSupply = new PowerSupply(PowerSupplyStrength._300to450),
                Cooling = new Cooling(CoolingType.passive)
            };

            mockBuilder.Setup(b => b.GetResult()).Returns(expectedComputer);

            // Act
            var result = mockBuilder.Object.GetResult();

            // Assert
            Assert.Equal(expectedComputer.Name, result.Name);
            Assert.Equal(expectedComputer.CPU.ToString(), result.CPU.ToString());
            Assert.Equal(expectedComputer.GPU.ToString(), result.GPU.ToString());
            Assert.Equal(expectedComputer.RAM.ToString(), result.RAM.ToString());
            Assert.Equal(expectedComputer.Storage.ToString(), result.Storage.ToString());
            Assert.Equal(expectedComputer.PowerSupply.ToString(), result.PowerSupply.ToString());
            Assert.Equal(expectedComputer.Cooling.ToString(), result.Cooling.ToString());
        }
    }
}
