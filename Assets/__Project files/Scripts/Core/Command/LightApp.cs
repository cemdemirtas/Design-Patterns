
using System.Collections.Generic;

namespace Nasser.io.DesignPatterns
{
    //invoker
    public class LightApp
    {
        Stack<ICommand> commandList;

        public LightApp()
        {
            commandList = new Stack<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            command.Execute();
            commandList.Push(command);
        }

        public void UndoCommand()
        {
            if (commandList.Count > 0)
            {
                ICommand lastCommand = commandList.Pop();
                lastCommand.Undo();
            }
        }
    }
}
