﻿//*************************************************************************************************
// DEBUT DU FICHIER
//*************************************************************************************************

//*************************************************************************************************
// Nom           : LocalTime.cs
// Auteur        : Nicolas Dagnas
// Description   : Déclaration de l'objet LocalTime
// Environnement : Visual Studio 2010
// Créé le       : 09/12/2016
// Modifié le    : 10/12/2016
//*************************************************************************************************

//-------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------
using System;
using Windows.Networking.Connectivity;
//-------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------

//*************************************************************************************************
// Début du bloc "System"
//*************************************************************************************************
namespace System
    {

    //   ###    ###   #####  #   ###   #   #   ####
    //  #   #  #   #    #    #  #   #  ##  #  #    
    //  #####  #        #    #  #   #  # # #   ### 
    //  #   #  #   #    #    #  #   #  #  ##      #
    //  #   #   ###     #    #   ###   #   #  #### 

	//*********************************************************************************************
	// Classe Network
	//*********************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------
	/// <summary>
	/// Enumère les Actions possibles.
	/// </summary>
	//---------------------------------------------------------------------------------------------
    public static class Network
        {
	    //-----------------------------------------------------------------------------------------
        // Section des Attributs
	    //-----------------------------------------------------------------------------------------
		private static DateTime LastCheck        = DateTime.MinValue;
		private static bool     NetworkAvailable = false;
        //-----------------------------------------------------------------------------------------

    	//*****************************************************************************************
        /// <summary>
        /// Indique si une connexion internet est disponible.
        /// </summary>
    	//-----------------------------------------------------------------------------------------
        public static bool InternetNetworkAvailable
            {
    	    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            get
                {
                if ( DateTime.UtcNow.Subtract ( LastCheck ).TotalMinutes > 1 )
                    {
					try
						{
        				var Conn = NetworkInformation.GetInternetConnectionProfile ();

		        		NetworkAvailable = Conn != null && Conn.GetNetworkConnectivityLevel () == 
						                                   NetworkConnectivityLevel.InternetAccess;
						LastCheck = DateTime.UtcNow;
						}
					catch {}
                    }
                
                return NetworkAvailable;
                }
    	    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            }
    	//*****************************************************************************************
        }
	//---------------------------------------------------------------------------------------------
	#endregion
	//*********************************************************************************************

	} // Fin du namespace "System"
//*************************************************************************************************

//*************************************************************************************************
// FIN DU FICHIER
//*************************************************************************************************