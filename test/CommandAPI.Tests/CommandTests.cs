using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests{
    public class CommandTests : IDisposable{

        Command testCommand;
        public CommandTests(){
            testCommand = new Command{
                HowTo = "Do Something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }

        public void Dispose(){

            testCommand = null;
        }

        [Fact]
        public void canChangeHowTo(){
            //Arrange: Create a testCommand and populate with initial values
            /* var testCommand = new Command{
                HowTo = "Do Something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            }; */
            //Act: Perform the action we want to test, that is, change the value of HowTo.
            testCommand.HowTo = "Execute Unit Tests";

            //Assert: Check that value of HowTo Matches what are expect.
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform(){
            //Arrange

            //Act
            testCommand.Platform = "xUnit";

            //Assert
            Assert.Equal("xUnit", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine(){
            //Arrange

            //Act
            testCommand.CommandLine = "dotnet test";

            //Assert
            Assert.Equal("dotnet test",testCommand.CommandLine);

        }


    }
}