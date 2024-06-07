using Net_08._Polymorphism;

Base myBase = new();
//myBase.Show();

Derived derived = new Derived();
//derived.Show();

Child child = new Child();
//child.Show();

// Derived is Base
Base derive = new Derived();
//((Derived)derive).Show();


//Foo(myBase);
//Foo(derived);
//Foo(child);

Base[] bases = new Base[] { myBase, derive, derived, child };

//bases[2].Show();

foreach (var item in bases)
{
    item.Show();
}
void Foo(Base myBase)
{
    #region V 1
    //if (myBase.GetType() == new Derived().GetType())
    //{
    //    ((Derived)myBase).Show();
    //}
    //else if (myBase.GetType() == new Child().GetType())
    //{
    //    ((Child)myBase).Show();
    //}
    //else
    //{
    //    myBase.Show();
    //}
    #endregion

    #region V 2

    //try
    //{
    //    ((Derived)myBase).Show();
    //}
    //catch (Exception)
    //{
    //}
    //try
    //{
    //    ((Child)myBase).Show();
    //}
    //catch (Exception)
    //{
    //}
    //try
    //{
    //    myBase.Show();
    //}
    //catch (Exception)
    //{
    //}
    #endregion

    #region V 3

    //if (myBase is Derived)
    //{
    //    ((Derived)myBase).Show();
    //}
    //else if (myBase is Child)
    //{
    //    ((Child)myBase).Show();
    //}
    //else
    //{
    //    myBase.Show();
    //}

    #endregion

    #region V 4
    //(myBase as Derived)?.Show();
    //(myBase as Child)?.Show();
    //(myBase as Base)?.Show();
    #endregion

    myBase.Show();
}