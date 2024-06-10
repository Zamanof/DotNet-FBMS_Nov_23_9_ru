// Abstract class
Pokemon pokemon1 = new Ekans("Hi", 78);

Ekans ekans = new("myEkans", 25);
Arbok arbok = new("myArbok", 65);
Charmander charmander = new("myCharmnader", 13);

Pokemon[] pokemons =
{
    ekans, 
    arbok, 
    charmander,
    new Charmander("otherCharmander", 78)
};

PoisonPokemon[] poisonPokemons =
{
    ekans,
    arbok
};

foreach (Pokemon pokemon in pokemons)
{
    //pokemon.SuperAttack();
    PokemonAttack(pokemon);
}


foreach (PoisonPokemon pokemon in poisonPokemons)
{
    PoisonPokemonsAttack(pokemon);
}
void PokemonAttack(Pokemon pokemon)
{
    pokemon.Attack();
    pokemon.SuperAttack();
    Console.WriteLine();
}

void PoisonPokemonsAttack(PoisonPokemon poisonPokemon)
{
    poisonPokemon.Attack();
    poisonPokemon.SuperAttack();
    poisonPokemon.PoisonAttack();
    Console.WriteLine();
}
abstract class Pokemon
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Level { get; set; } = 1;
    public abstract void Attack();
    public abstract void SuperAttack();
    public void ShowInfo()
    {
        Console.WriteLine("Pokemons mean Pocket Monster");
    }
}

abstract class PoisonPokemon : Pokemon
{
    public abstract void PoisonAttack(); 
}

abstract class FirePokemon : Pokemon 
{
    public abstract void FireAttack();
}

class Arbok : PoisonPokemon
{
    public Arbok(string name, int hp)
    {
        Name = name;
        HP = hp;
    }

    public override void Attack()
    {
        Console.WriteLine("Arbok Attacked");
    }

    public override void PoisonAttack()
    {
        Console.WriteLine("Arbok Attacked with poison");
    }

    public override void SuperAttack()
    {
        Console.WriteLine("Arbok Super attack");
    }
}

class Ekans: PoisonPokemon
{
    public Ekans(string name, int hp)
    {
        Name = name;
        HP = hp;
    }

    public override void Attack()
    {
        Console.WriteLine("Ekans Attacked");
    }

    public override void PoisonAttack()
    {
        Console.WriteLine("Ekans Attacked with poison");
    }

    public override void SuperAttack()
    {
        Console.WriteLine("Ekans Super attack");
    }
}

class Charmander : FirePokemon
{
    public Charmander(string name, int hp)
    {
        Name = name;
        HP = hp;
    }

    public override void Attack()
    {
        Console.WriteLine("Chramander Attacked");
    }

    public override void FireAttack()
    {
        Console.WriteLine("Chramander Attacked with fire");
    }

    public override void SuperAttack()
    {
        Console.WriteLine("Chramander Super Attack");
    }
}
