using System;

// ============================================
// ПРАКТИКА: Наследование
// Задание: Создать класс Archer
// Время: 10 минут
// ============================================

// Базовый класс (готовый)
class Character
{
    protected string name;
    protected int health;
    protected int maxHealth;
    protected int damage;
    
    public Character(string name, int health, int damage)
    {
        this.name = name;
        this.health = health;
        this.maxHealth = health;
        this.damage = damage;
    }
    
    public virtual void TakeDamage(int incomingDamage)
    {
        health -= incomingDamage;
        if (health < 0) health = 0;
        Console.WriteLine($"{name} получил {incomingDamage} урона! HP: {health}/{maxHealth}");
    }
    
    public bool IsAlive() => health > 0;
    
    public virtual void ShowStatus()
    {
        string status = IsAlive() ? "💚" : "💀";
        Console.WriteLine($"{name} | HP: {health}/{maxHealth} | {status}");
    }
}

// Warrior (для примера)
class Warrior : Character
{
    private int armor;
    
    public Warrior(string name, int health, int damage, int armor)
        : base(name, health, damage)
    {
        this.armor = armor;
    }
    
    public void Attack()
    {
        Console.WriteLine($"⚔️ {name} бьёт мечом за {damage} урона!");
    }
    
    public override void TakeDamage(int incomingDamage)
    {
        int actualDamage = incomingDamage - armor;
        if (actualDamage < 0) actualDamage = 0;
        health -= actualDamage;
        if (health < 0) health = 0;
        Console.WriteLine($"🛡️ {name} блокировал {armor}! HP: {health}/{maxHealth}");
    }
    
    public override void ShowStatus()
    {
        string status = IsAlive() ? "💚" : "💀";
        Console.WriteLine($"[⚔️ ВОИН] {name} | HP: {health}/{maxHealth} | Броня: {armor} | {status}");
    }
}

// Mage (для примера)
class Mage : Character
{
    private int mana;
    private int maxMana;
    
    public Mage(string name, int health, int damage, int mana)
        : base(name, health, damage)
    {
        this.mana = mana;
        this.maxMana = mana;
    }
    
    public void Attack()
    {
        if (mana >= 20)
        {
            Console.WriteLine($"🔥 {name} кастует огненный шар за {damage} урона!");
            mana -= 20;
        }
        else
        {
            Console.WriteLine($"💨 У {name} нет маны!");
        }
    }
    
    public override void ShowStatus()
    {
        string status = IsAlive() ? "💚" : "💀";
        Console.WriteLine($"[🔮 МАГ] {name} | HP: {health}/{maxHealth} | Мана: {mana}/{maxMana} | {status}");
    }
}

// TODO 1: Создайте класс Archer, наследующий от Character
class Archer  // ← Добавьте наследование
{
    // TODO 2: Объявите поле arrows (int)
    
    
    // TODO 3: Создайте конструктор
    // Подсказка: Принимает name, health, damage, arrows
    //            Вызывает base(name, health, damage)
    public Archer(/* параметры */)
        // ← вызов base
    {
        // Ваш код здесь:
        
    }
    
    // TODO 4: Метод Attack
    // Подсказка: Если arrows > 0, стреляет и уменьшает arrows на 1
    //            Иначе выводит "Стрелы закончились!"
    public void Attack()
    {
        // Ваш код здесь:
        
        
        
        
    }
    
    // TODO 5: Переопределите ShowStatus
    // Подсказка: Покажите [🏹 ЛУЧНИК] имя | HP | Стрелы: X
    public /* override */ void ShowStatus()
    {
        // Ваш код здесь:
        
    }
}

// ТЕСТИРОВАНИЕ (не трогать)
class Program
{
    static void Main()
    {
        Console.WriteLine("=== ТЕСТ НАСЛЕДОВАНИЯ ===\n");
        
        Warrior warrior = new Warrior("Конан", 150, 30, 20);
        Mage mage = new Mage("Гендальф", 80, 50, 100);
        Archer archer = new Archer("Леголас", 100, 35, 50);
        
        Console.WriteLine("--- Статус всех героев ---");
        warrior.ShowStatus();
        mage.ShowStatus();
        archer.ShowStatus();
        
        Console.WriteLine("\n--- Все атакуют ---");
        warrior.Attack();
        mage.Attack();
        archer.Attack();
        
        Console.WriteLine("\n--- Получение урона ---");
        warrior.TakeDamage(40);
        mage.TakeDamage(40);
        archer.TakeDamage(40);
        
        Console.WriteLine("\n--- Финальный статус ---");
        warrior.ShowStatus();
        mage.ShowStatus();
        archer.ShowStatus();
        
        Console.WriteLine("\n✅ Если Archer работает как Warrior и Mage - вы освоили наследование!");
    }
}