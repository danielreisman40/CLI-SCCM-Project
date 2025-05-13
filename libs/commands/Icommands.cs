
/**
 *
 * All Shell functions will have the same basic features,
 * "Name" -> Name of the function
 * "Description" -> What the function does
 * "Func Params" -> What parameters the command can take in
 * "Execute" -> Executes the command 
 * */

namespace CLI_SCCM_Project.libs.Commands {

    public interface ICommands {
        
        string name {get;}
        string description {get;}
        string[] func_args {get;}
        void execute(string[] args);

    }
}
