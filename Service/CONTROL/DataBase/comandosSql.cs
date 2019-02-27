using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.CONTROL.Banco
{
    public partial class comandosSql : Form
    {
        public comandosSql()
        {
            InitializeComponent();
        }

        public String queryAtualizaTranferenciaServico(String handle)
        {
            String query = "UPDATE SV_SERVICO SET EHTRANSFERENCIA = 1 WHERE HANDLE = " + handle;

            return query;
        }

        public String queryAtualizaDuracao()
        {
            String query = " UPDATE SV_SERVICO SET DURACAO = DATEDIFF(hh, DATAINICIAL, DATAFINAL) WHERE HANDLE = (SELECT MAX(XX.HANDLE) FROM SV_SERVICO XX)";
            return query;

        }

        public String queryAtualizaDuracaoHandle(String handleServico)
        {
            String query = " UPDATE SV_SERVICO SET DURACAO = DATEDIFF(hh, DATAINICIAL, DATAFINAL) WHERE HANDLE = " + handleServico;
            return query;
        }

        public String queryDesatualizaAreaDeTransferencia()
        {
            String query = "UPDATE SV_SERVICO SET EHTRANSFERENCIA = 0 WHERE EHTRANSFERENCIA <> 0";
            return query;
        }
        public String queryAtualizaDataInicial(String handleService, String dataNova)
        {
            String query = "UPDATE SV_SERVICO SET DATAINICIAL = '" + dataNova + "' WHERE HANDLE = " + handleService;
            return query;
        }
        
        public String queryAtualizaDataFinal(String handleService, String dataNova)
        {
            String query = "UPDATE SV_SERVICO SET DATAFINAL = '" + dataNova + "' WHERE HANDLE = " + handleService;
            return query;
        }

        public String queryConsultaTodosServico(String equipe, String status, String referencia)
        {
            String query =

                " SELECT                                                                    " +
                "   A.HANDLE ORDEM ," +
                "   D.NOME    SITUACAO ,                                                        " +
                "   A.DATAINICIAL DATA,                                               " +
                "   C.NOME EQUIPE     ,                                             " +
                "   A.SERVICO,                                                           " +
                "   B.NOME CLIENTE                                                 " +
                "  FROM SV_SERVICO A                                           " +
                "  INNER JOIN SV_EQUIPE  C ON A.EQUIPE   = C.HANDLE " +
                "  INNER JOIN SV_CLIENTE B ON A.CLIENTE  = B.HANDLE " +
                "  INNER JOIN SV_STATUS  D ON A.STATUS   = D.HANDLE " +
                "  INNER JOIN SV_ENDERECO E ON B.ENDERECO = E.HANDLE " +
                "  INNER JOIN SV_REFERENCIA F ON E.REFERENCIA = F.HANDLE " +
                "  WHERE C.NOME  = '" + equipe + "'" +
                "  AND D.NOME = '"    + status + "'" +
                "  AND F.REFERENCIA = '" + referencia + "'" +
                "  ORDER BY A.DATAINICIAL  ;";

            return query;

        }
    }
}
