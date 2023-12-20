// See https://aka.ms/new-console-template for more information
// Компоновщик (Composite)
// структурный паттерн, позволяющий инкапсулировать 
// работу множества компонентов внутри одного класса,
// который выступает в роли компоновщика

Directory directory = new Directory { Name = "1125" };
directory.AddObject(new File { Name = "Черный списочек должников 1125.txt" });
directory.AddObject(new File { Name = "Белый списочек 1125.txt" });
Directory directory1 = new Directory { Name = "Посещаемость" };
directory1.AddObject(new File { Name = "Белый списочек 1125.txt" });
directory1.AddObject(new File { Name = "Черный списочек должников 1125.txt" });

directory.AddObject(directory1);

directory.GetObjects();
Console.WriteLine();

directory1.GetObjects();

public abstract class FileSystemObject
{ 
    public string Name { get; set; }
}

public class File : FileSystemObject
{ 

}

public class Directory : FileSystemObject
{
    List<FileSystemObject> fileSystemObjects;
    public Directory()
    {
        fileSystemObjects = new List<FileSystemObject>();
    }

    public void AddObject(FileSystemObject obj)
    {
        fileSystemObjects.Add(obj);
    }

    public void RemoveObject(FileSystemObject obj)
    {
        fileSystemObjects.Remove(obj);
    }

    public void GetObjects()
    {
        Console.WriteLine($"Содержимое папки: {Name}:");
        foreach (FileSystemObject obj in fileSystemObjects)
        {
            Console.WriteLine($"{obj.Name} : {obj}");
        }
    }
}

/*
Composite composite = new Composite();
composite.AddComponent(new ConcreteComponent1());
composite.AddComponent(new ConcreteComponent1());
composite.AddComponent(new ConcreteComponent2());
// вызов операций
composite.Operation();


public abstract class AbstractComponent
{
    public abstract void Operation();
}

public class Composite : AbstractComponent
{
    List<AbstractComponent> components;

    public Composite()
    {
        components = new List<AbstractComponent>();
    }

    public void AddComponent(AbstractComponent component)
    {
        components.Add(component);
    }

    public void RemoveComponent(AbstractComponent component)
    {
        components.Remove(component);
    }

    public void Operation()
    {
        // тут вызов соответствующих методов в 
        // компонентах
        foreach (var component in components)
        {
            component.Operation();
        }
    }
}

public class ConcreteComponent1: AbstractComponent
{
    public override void Operation()
    {
        Console.WriteLine("Выполнение операции 1");
    }
}
public class ConcreteComponent2 : AbstractComponent
{
    public override void Operation()
    {
        Console.WriteLine("Выполнение операции 2");
    }
}
*/