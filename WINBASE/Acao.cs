using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.WINBASE
{
    public enum Acao
    {
         INSERIR = 0,
         ALTERAR = 1,
         CONSULTAR = 2,
         EXCLUIR = 3
    }

    public enum EnumTipoPedido
    {
        PEDIDO = 1,
        ORÇAMENTO =2
    }

    public enum EnumOperacao
    {
        VENDA = 1,
        ORÇAMENTO =2,
        PAGAR = 3
    }

    public enum EnumSituacao
    {
        EXCLUÍDO = 1,
        ABERTO = 2,
        FINALIZADO = 3,
        PAGO = 4
    }

    public enum EnumTipoComboBox
    {
        ATIVO =1,
        OPERAÇÃO = 2
    }
    public enum EnumSituacaoContasReceber
    {
        ABERTA =1,
        PAGA =2,
        EXCLUÍDA = 3
    }

    public enum EnumContasReceberOrigem
    {
        MANUAL = 1,
        AUTOMÁTICO = 2
    }
}
