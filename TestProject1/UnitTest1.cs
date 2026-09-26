namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int val1 = 3;
            int val2 = 5;

            int resultEsperado = 8;

            int result = val1 + val2;

            Assert.Equal(resultEsperado, result);
        }

        [Fact]
        public void String_NaoDeveSerVazia()
        {
            // Arrange
            string texto = "PDV Mercadinho";

            // Act
            bool naoEstaVazio = !string.IsNullOrEmpty(texto);

            // Assert
            Assert.True(naoEstaVazio, "O texto não deve estar vazio");
        }
    }
}
