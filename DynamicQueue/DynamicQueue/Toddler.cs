namespace Playground_queue
{
    public delegate void delOnAssistanceNeeded(Toddler toddler);

    public class Toddler
    {        
        //Properties
        public string Name { get; private set; }
        public Skill Skill { get; private set; }

        //Constructor
        public Toddler(string name, Skill skill)
        {
            Name = name;
            this.Skill = skill;
        } //ctor

        //ToString
        public override string ToString()
        {
            return Name + " (" + Skill + ")";
        } //ToString

        public event delOnAssistanceNeeded OnAssistanceNeeded;

        public void Slide()
        {
            if (Skill == Skill.Inept || Skill == Skill.Decent)
                OnAssistanceNeeded?.Invoke(this);

            //if (Skill == Skill.Inept || Skill == Skill.Decent)
            //    if (OnAssistanceNeeded != null)
            //        OnAssistanceNeeded(this);
        }

    }  //class Toddler
} //namespace
