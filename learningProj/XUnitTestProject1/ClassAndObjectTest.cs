using ClassAndObject;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class ClassAndObjectTest
    {
        [Fact]
        public void Verificar_Latido_Dog()
        {

            // arrange
            Dog dog = new Dog();

            //act
            var latido = dog.Latir();

            //assert
            Assert.Equal("Au au au", latido);

        }
    }
}
