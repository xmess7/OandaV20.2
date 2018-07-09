﻿using OkonkwoOandaV20.TradeLibrary.DataTypes.Position;
using System.Threading.Tasks;

namespace OkonkwoOandaV20.TradeLibrary.REST
{
   public partial class Rest20
   {
      /// <summary>
      /// Retrieves the current position for the given instrument and account
      /// This will cause an error if there is no position for that instrument 
      /// </summary>
      /// <param name="accountID">the account for which to get the position</param>
      /// <param name="instrument">the instrument for which to get the position</param>
      /// <returns>Position object with the details of the position</returns>
      public static async Task<Position> GetPositionAsync(string accountID, string instrument)
      {
         string requestString = ServerUri(Server.Account) + "accounts/" + accountID + "/positions/" + instrument;

         var response = await MakeRequestAsync<PositionResponse>(requestString);

         return response.position;
      }
   }

   public class PositionResponse : Response
   {
      /// <summary>
      /// The requested Position
      /// </summary>
      public Position position { get; set; }
   }
}