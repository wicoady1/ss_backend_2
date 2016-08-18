﻿using System;
using System.Data;
using Mono.Data.Sqlite;
using System.Xml;

namespace ss_backend_assess.Model
{
	public class ConfirmOrderModel
	{
		private ss_backend_assess.connString _conn;

		public ConfirmOrderModel (connString conn)
		{
			this._conn = new connString ();
			this._conn = conn;
		}

		//--- check coupon code + bonus
		public DataTable CheckCouponCode (string strCode){
			string strQuery = "select * from tblCoupon where Code = '" + strCode + "'";
			DataSet dsResult = new DataSet ();

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);
			//_conn.sqlReader = _conn.sqlComm.ExecuteReader ();

			_conn.sqlDataAdapter = new Mono.Data.Sqlite.SqliteDataAdapter (strQuery, _conn.sqlConn);
			dsResult.Reset ();
			_conn.sqlDataAdapter.Fill (dsResult);
			_conn.sqlConn.Close ();

			return dsResult.Tables [0];
		}

		//--- check item price
		public int CheckItemPrice (string strCode){
			string strQuery = "select Price from tblProductData where ProductID = '" + strCode + "'";
			DataSet dsResult = new DataSet ();

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);
			//_conn.sqlReader = _conn.sqlComm.ExecuteReader ();

			_conn.sqlDataAdapter = new Mono.Data.Sqlite.SqliteDataAdapter (strQuery, _conn.sqlConn);
			dsResult.Reset ();
			_conn.sqlDataAdapter.Fill (dsResult);
			_conn.sqlConn.Close ();

			return Convert.ToInt32(dsResult.Tables [0].Rows [0] ["Price"].ToString ());
		}

		//--- check item stock
		public int CheckItemStock (string strCode){
			string strQuery = "select Stock from tblProductData where ProductID = '" + strCode + "'";
			DataSet dsResult = new DataSet ();

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);
			//_conn.sqlReader = _conn.sqlComm.ExecuteReader ();

			_conn.sqlDataAdapter = new Mono.Data.Sqlite.SqliteDataAdapter (strQuery, _conn.sqlConn);
			dsResult.Reset ();
			_conn.sqlDataAdapter.Fill (dsResult);
			_conn.sqlConn.Close ();

			return Convert.ToInt32(dsResult.Tables [0].Rows [0] ["Stock"].ToString ());
		}

		//--- cut item stock
		public void CutItemStock (string strCode, int intQty){
			string strQuery = "update tblProductData set Stock = Stock - " + intQty.ToString () + " where ProductID = '" + strCode + "'";
			//string strQuery = "update tblProductData set Stock = Stock - @intQty where ProductID = '@strCode'";

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);

			//_conn.sqlComm.CommandText = "update tblProductData set Stock = Stock - @intQty where ProductID = '@strCode'";
			//_conn.sqlComm.Parameters.AddWithValue ("@intQty", intQty);
			//_conn.sqlComm.Parameters.AddWithValue ("@strCode", strCode);
			//_conn.sqlComm.Parameters.Add (intQty.ToString());
			//_conn.sqlComm.Parameters.Add (strCode);

			_conn.sqlComm.ExecuteNonQuery ();

			_conn.sqlConn.Close ();

		}

		//--- cut coupon stock
		public void CutCouponStock (string strCode){
			string strQuery = "update tblCoupon set Qty = Qty - 1 where Code = '" + strCode + "'";
			//string strQuery = "update tblCoupon set Qty = Qty - 1 where Code = '?'";

			_conn.sqlConn.Open ();
			_conn.sqlComm = new SqliteCommand (strQuery, _conn.sqlConn);

			//_conn.sqlComm.Parameters.Add (strCode);

			_conn.sqlComm.ExecuteNonQuery();

			_conn.sqlConn.Close ();
		}
	}
}

