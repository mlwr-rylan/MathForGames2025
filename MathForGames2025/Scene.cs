namespace MathForGames2025
{
    internal class Scene
    {
        private Actor[] _actors;

        public void AddActor( Actor actor)
        {
            if (_actors == null)
            {
                _actors = new Actor[0];
            }
            Actor[] temp = new Actor[_actors.Length + 1]; 

            for(int i = 0; i< _actors.Length; i++)
            {
                temp[i] = _actors[i];
            }
                temp[_actors.Length] = actor;
            _actors = temp;
        }
        public bool Remove(Actor actorToRemove)
        {
           

            if(actorToRemove == null)
            {
                return false;
            }
            if(_actors == null || _actors.Length == 0)
            {
                return false;
            }
            Actor[] temp = new Actor[_actors.Length + 1];

            bool actorRemoved = true;

            int j = 0;

            for (int i = 0; i < _actors.Length; i++)
            {

                if (_actors[i] == actorToRemove)
                {
                    actorRemoved = true;
                    continue;
                }
                temp[j] = _actors[i];
                j++;
            }
            return actorRemoved;
        }
        public virtual void Start()
        {

        }

        public virtual void Update(float deltaTime)
        {
            for(int i = 0; i < _actors.Length; i++)
            {
                if (!_actors[1].Started)
                {
                    _actors[i].Start();
             
                }
                _actors[1].Update(deltaTime);
            }
        }

        public virtual void Draw()
        {
            for (int i = 0; i < _actors.Length; i++)
            {
                _actors[i].Draw();
            }
        }

        public virtual void End()
        {
            for (int i = 0; i < _actors.Length; i++)
            {
                _actors[i].Draw();
            }
        }
    }
}
