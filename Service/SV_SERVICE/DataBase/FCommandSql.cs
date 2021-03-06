﻿using System;
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
                "  WHERE ((C.NOME  = '" + equipe + "') AND (D.NOME = '"    + status + "') AND (F.REFERENCIA = '" + referencia + "'))" +
                "  ORDER BY A.DATAINICIAL  ;";

            return query;

        }

      public String vQueryConsultServices(String handleService)
        {                              
             String query = "SELECT A.HANDLE 'Numero' ,B.NOME 'Cliente', C.NOME 'Equipe', A.DURACAO 'Duracao' FROM SV_SERVICO A INNER JOIN SV_CLIENTE B ON A.CLIENTE = B.HANDLE INNER JOIN SV_EQUIPE C ON A.EQUIPE = C.HANDLE WHERE A.HANDLE = " + handleService;
             return query;
        }

        public String vQueryConsultEquipe(String prNameTeam, String prHandleService)
        {
            String query = "SELECT A.HANDLE FROM SV_EQUIPE A" +
                "                  INNER JOIN SV_SERVICO B ON B.EQUIPE = A.HANDLE" +
                "                   WHERE A.NOME LIKE '%" + prNameTeam + " %'" +
                "                   AND B.HANDLE = " + prHandleService;
            return query;

        }

        public String vQueryConsultMaxService()
        {
            String query = "SELECT MAX(A.HANDLE) HANDLE FROM SV_SERVICO A";
            return query;
        }

        public String vQueryRefreshDateService(String prStartDate, String prEndDate, int prHandleService)
        {
            String vQuery = "UPDATE SV_SERVICO SET DATAINICIAL = '" + prStartDate + "', DATAFINAL = '" + prEndDate + " ' WHERE HANDLE = " + prHandleService;
            return vQuery;
        }

        public String vQueryConsultAllFromReferences()
        {
            String vQuery = "SELECT  " +
                                            " HANDLE ID, " +
                                           "  REFERENCIA, " + 
                                           "  RUA, " +
                                           " BAIRRO, " +
                                           " CIDADE " +
                                           " FROM SV_REFERENCIA";
            return vQuery;
        }


        public String vQueryConsultDateBetween( String prStartDate, String prEndDate, String prTeam)
        {
            String vQuery =  "SELECT HANDLE FROM SV_SERVICO WHERE EQUIPE = " + prTeam + " AND (DATAINICIAL  <= '" +  prStartDate + "' AND DATAFINAL  >= '" + prEndDate + "')" +
                                                    " OR(DATAINICIAL >= '" + prStartDate + "' AND DATAFINAL <= '" + prStartDate + "');";
          
            return vQuery;
        }

    }
}
