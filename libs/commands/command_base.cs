

namespace CLI_SCCM_Project.libs.Commands {

    public abstract class command_shell_base : ICommands {
       
        public abstract string name {get; }
        public abstract string description {get; }
        public abstract string[] func_args {get; }
        public abstract void execute(string[] args);
    } 

}
