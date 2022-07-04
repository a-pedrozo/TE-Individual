using System;
using System.Collections.Generic;
using System.Text;
using DadabaseApp;
using DadabaseApp.Models;
using DadJokesServer.Models;
using RestSharp;

namespace DadabaseClient.ApiClients
{
    public class AuthenticationRestClient
    {
        private readonly RestClient client;

        public AuthenticationRestClient()
        {
            this.client = new RestClient("https://localhost:44301/"); // ASP .NET is running on this port
        }

        public bool Register(string username, string password)
        {
            RestRequest request = new RestRequest("login/register");

            LoginInfo login = new LoginInfo();
            login.Username = username;
            login.Password = password;

            request.AddJsonBody(login);

            IRestResponse<UserInfo> response = client.Post<UserInfo>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the dad-a-base; Try again later!");

                return false;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Problem registering: " + response.StatusDescription);
                Console.WriteLine(response.Content);

                return false;
            }

            return response.IsSuccessful;
        }

        public UserInfo Login(string username, string password)
        {
            RestRequest request = new RestRequest("login");

            LoginInfo login = new LoginInfo();
            login.Username = username;
            login.Password = password;

            request.AddJsonBody(login);

            IRestResponse<UserInfo> response = client.Post<UserInfo>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the dad-a-base; Try again later!");

                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Problem logging in: " + response.StatusDescription);
                Console.WriteLine(response.Content);

                return null;
            }

            return response.Data;
        }
    }
}
