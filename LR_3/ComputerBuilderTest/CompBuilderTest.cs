using ComputerLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ComputerBuilderTests
{
    [TestClass()]
    public class CompBuilderTest
    {
        [TestMethod]
        public void CPUTest_SetCPU_SetsCorrectCPU()
        {
            // Arrange
            var builder = new ComputerBuilder();
            var expectedCPU = new CPU(CPUType.gaming, CPUManufacturer.AMD, CPULine.Ryzen_7_5750G_PRO);

            // Act
            builder.SetCPU(expectedCPU);
            var computer = builder.GetResult();

            // Assert
            Assert.AreEqual(expectedCPU, computer.CPU);
        }

        [TestMethod]
        public void GPUTest_SetGPU_SetsCorrectGPU()
        {
            // Arrange
            var builder = new ComputerBuilder();
            var expectedGPU = new GPU(GPUType.gaming, GPUManufacturer.GeForce, GPULine.GV_N730D5_2GL);

            // Act
            builder.SetGPU(expectedGPU);
            var computer = builder.GetResult();

            // Assert
            Assert.AreEqual(expectedGPU, computer.GPU);
        }

        [TestMethod]
        public void RAMTest_SetRAM_SetsCorrectRAM()
        {
            // Arrange
            var builder = new ComputerBuilder();
            var expectedRAM = new RAM(RAMType.DDR2, RAMSize._16GB);

            // Act
            builder.SetRAM(expectedRAM);
            var computer = builder.GetResult();

            // Assert
            Assert.AreEqual(expectedRAM, computer.RAM);
        }

        [TestMethod]
        public void StorageTest_SetStorage_SetsCorrectStorage()
        {
            // Arrange
            var builder = new ComputerBuilder();
            var expectedStorage = new Storage(StorageType.SSD, StorageSize._512);

            // Act
            builder.SetStorage(expectedStorage);
            var computer = builder.GetResult();

            // Assert
            Assert.AreEqual(expectedStorage, computer.Storage);
        }

        [TestMethod]
        public void PowerSupplyTest_SetPowerSupply_SetsCorrectPowerSupply()
        {
            // Arrange
            var builder = new ComputerBuilder();
            var expectedPowerSupply = new PowerSupply(PowerSupplyStrength._500to650);

            // Act
            builder.SetPowerSupply(expectedPowerSupply);
            var computer = builder.GetResult();

            // Assert
            Assert.AreEqual(expectedPowerSupply, computer.PowerSupply);
        }

        [TestMethod]
        public void CoolingSystemTest_SetCoolingSystem_SetsCorrectCoolingSystem()
        {
            // Arrange
            var builder = new ComputerBuilder();
            var expectedCooling = new Cooling(CoolingType.water);

            // Act
            builder.SetCoolingSystem(expectedCooling);
            var computer = builder.GetResult();

            // Assert
            Assert.AreEqual(expectedCooling, computer.Cooling);
        }

    }
}
