using System;

namespace DigiMoallem.BLL.Helpers.Generators
{
    public class CodeGenerator
    {
        public static string GenerateUniqueCode() {
            return Guid.NewGuid().ToString().Replace("-","");
        }
    }
}
