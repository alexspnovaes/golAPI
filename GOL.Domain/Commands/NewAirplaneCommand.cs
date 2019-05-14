using GOL.Commom.Publisher;
using GOL.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOL.Domain.Commands
{
    public class NewAirplaneCommand : Command
    {
        public NewAirplaneCommand(string codigoAviao, string modelo, int qtdePassageiros)
        {
            CodigoAviao = codigoAviao;
            Modelo = modelo;
            QtdPassageiros = qtdePassageiros;
        }

        public string CodigoAviao { get;  set; }
        public string Modelo { get;  set; }
        public int QtdPassageiros { get;  set; }

        public override bool IsValid()
        {
            return new NewAirplaneCommandValidation().Validate(this).IsValid;
        }
    }
}
