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
    public partial class controles : Form
    {
        public controles()
        {
            InitializeComponent();
        }


     public void alteratabelaDataAgendamento(String servico, String dataNova, String dataFinal)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();

            String queryDelete = "DELETE FROM SV_DATAAGENDAMENTO WHERE SERVICO = " + servico;
            conexao.insert(queryDelete);


            DateTime dataSemConversao = DateTime.Parse(dataNova);
            String dataConvertida = dataSemConversao.ToString("yyyy/dd/MM HH:mm:ss");

            DateTime dataFinalSemConversao = DateTime.Parse(dataFinal);
            String dataFinalConvertida = dataFinalSemConversao.ToString("yyyy/dd/MM HH:mm:ss");

            String dia = dataSemConversao.ToString("dd");
            String mes = dataSemConversao.ToString("MM");
            String hora = dataSemConversao.ToString("HH");
            String ano = dataSemConversao.ToString("yyyy");
            String horaFinal = dataFinalSemConversao.ToString("HH");


            int ihoraInicial = Convert.ToInt32(hora);
            int ihoraFinal = Convert.ToInt32(horaFinal);

            int salvarHora = -50;

            while (ihoraFinal - ihoraInicial > 0)
            {
                if (salvarHora == -50)
                {
                    String query = "INSERT INTO SV_DATAAGENDAMENTO VALUES (" +
                                                                       ihoraFinal + "," +
                                                                       mes + "," +
                                                                       ano + "," +
                                                                       dia + "," +
                                                                       servico + ")";

                    conexao.insert(query);
                    salvarHora = ihoraFinal - ihoraInicial;
                    ihoraFinal = ihoraFinal - 1;
                }
                else
                {

                    String query = "INSERT INTO SV_DATAAGENDAMENTO VALUES (" +
                                                                       ihoraFinal + "," +
                                                                       mes + "," +
                                                                       ano + "," +
                                                                       dia + "," +
                                                                       servico + ")";
                    conexao.insert(query);
                    ihoraFinal = ihoraFinal - 1;
                }
            }


        }

    }
}
