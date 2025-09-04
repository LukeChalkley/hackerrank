using System.Text;

namespace SolutionCode.Prepare.Data_Structures.Stacks;


public interface ITextEditorCommand
{
    void Execute(StringBuilder sb);
}

public interface IUndoTextEditorCommand : ITextEditorCommand
{
    void Undo(StringBuilder sb);
}

public class PrintStringCommand : ITextEditorCommand
{
    public void Execute(StringBuilder sb)
    {
        Console.WriteLine("Printing string.");
        
        if (sb.Length == 0)
            Console.WriteLine("[EMPTY STRING]");
        else
            Console.WriteLine(sb.ToString());
    }
}

public class PrintCommand : ITextEditorCommand
{
    private int _indexToPrint;
    
    public PrintCommand(int index)
    {
        _indexToPrint = index;
    }
    
    public void Execute(StringBuilder sb)
    {
        Console.WriteLine(sb.ToString()[_indexToPrint]);
    }
}

public class AppendCommand : IUndoTextEditorCommand
{
    private string _stringToAppend;
    
    public AppendCommand(string stringToAppend)
    {
        _stringToAppend = stringToAppend;
    }
    
    public void Execute(StringBuilder sb)
    {
        Console.WriteLine($"append {_stringToAppend}");
        sb.Append(_stringToAppend);
    }

    public void Undo(StringBuilder sb)
    {

        for (int i = 0; i < _stringToAppend.Length; i++)
        {
            Console.WriteLine($"Need to remove index {sb.Length - i}, character of {_stringToAppend[i]}");
        }
        
        sb.Remove(sb.Length - _stringToAppend.Length - 1, _stringToAppend.Length);
    }
}

public class DeleteCommand : IUndoTextEditorCommand
{
    private int _charsToDelete;
    private string _stringToDelete;
    
    public DeleteCommand(int charactersToRemove)
    {
        _charsToDelete = charactersToRemove;
    }
    
    public void Execute(StringBuilder sb)
    {
        Console.WriteLine($"removing the last {_charsToDelete} chars.");
        _stringToDelete = sb.ToString().Substring(sb.Length - _charsToDelete, _charsToDelete);
        Console.WriteLine($"Removing the characters {_stringToDelete}.");
        
        sb.Remove(sb.Length - _charsToDelete - 1, _charsToDelete);
    }

    public void Undo(StringBuilder sb)
    {
        sb.Append(_stringToDelete);
    }
}

public class SimpleTextEditor
{
    private Stack<IUndoTextEditorCommand> _commands = new Stack<IUndoTextEditorCommand>();
    private StringBuilder _stringBuilder = new StringBuilder();
    
    public SimpleTextEditor()
    {

    }

    public void AddCommandAndRun(ITextEditorCommand command)
    {
        // Add command to stack.
        if (command is IUndoTextEditorCommand undoCommand)
            _commands.Push(undoCommand);

        command.Execute(_stringBuilder);
    }

    public void UndoLast()
    {
        IUndoTextEditorCommand command = _commands.Pop();

        Console.WriteLine($"Undoing last command {command}.");
        
        command.Undo(_stringBuilder);
    }
}