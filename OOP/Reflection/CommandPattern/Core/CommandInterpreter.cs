﻿using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {

        private const string COMMAND_POSTFIX = "Command";

        public CommandInterpreter()
        {

        }

        public string Read(string args)
        {
            string[] commandTokens = args.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string commandName = commandTokens[0] + COMMAND_POSTFIX;
            string[] commandsArgs = commandTokens.Skip(1)
                .ToArray();
            
            Assembly assembly = Assembly.GetCallingAssembly();

            Type commandType = assembly.GetTypes()
                .FirstOrDefault(n => n.Name.ToLower() == commandName.ToLower());

            if (commandType == null)
            {
                throw new ArgumentException("Invalid command type!");
            }

            ICommand commandInstance = (ICommand)Activator
                .CreateInstance(commandType);

            string result = commandInstance.Execute(commandsArgs);
            return result;
        }

        public string Read(object args)
        {
            throw new NotImplementedException();
        }
    }
}
