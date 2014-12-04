using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Payment
{
    public enum PaymentStatus
    {
        CRIADO = 0,
        INICIADO = 1,
        AUTORIZADO = 2,
        BOLETO_IMPRESSO = 3, 
        CONCLUIDO = 4, 
        CANCELADO = 5, 
        EM_ANALISE = 6, 
        ESTORNADO = 7,
        REEMBOLSADO = 8,
        ERRO = 9
    }
}
