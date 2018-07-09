﻿using OkonkwoOandaV20.TradeLibrary.DataTypes.Account;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OkonkwoOandaV20.TradeLibrary.REST
{
   public partial class Rest20
   {
      /// <summary>
      /// Get a list of all Accounts authorized for the provided token.
      /// http://developer.oanda.com/rest-live-v20/account-ep/#_collapse_endpoint_2
      /// </summary>
      /// <returns>a List of AccountProperties that includes basic information about the accounts</returns>
      public static async Task<List<AccountProperties>> GetAccountsAsync()
      {
         string uri = ServerUri(Server.Account) + "accounts";

         var response = await MakeRequestAsync<AccountsResponse>(uri);
         return response.accounts;
      }
   }

   public class AccountsResponse : Response
   {
      /// <summary>
      /// The list of Accounts the client is authorized to access and their 
      /// associated properties.
      /// </summary>
		public List<AccountProperties> accounts;
   }
}