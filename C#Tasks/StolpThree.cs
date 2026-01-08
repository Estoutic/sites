using System;

// ============================================
// ПРАКТИКА: Полиморфизм
// Задание: Добавить virtual/override и работать с массивом
// Время: 10 минут
// ============================================

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
    
    // TODO 1: Добавьте ключевое слово virtual
    public /* virtual */ void Attack()
    {
        Console.WriteLine($"{name} атакует за {damage} урона!");
    }
    
    // TODO 2: Добавьте virtual
    public /* virtual */ void TakeDamage(int incomingDamage)
    {
        health -= incomingDamage;
        if (health < 0) health = 0;
        Console.WriteLine($"{name} получил {incomingDamage} урона! HP: {health}/{maxHealth}");
    }
    
    public bool IsAlive() => health > 0;
    
    // TODO 3: Добавьте virtual
    public /* virtual */ void ShowStatus()
    {
        string status = IsAlive() ? "💚" : "💀";
        Console.WriteLine($"{name} | HP: {health}/{maxHealth} | {status}");
    }
}

class Warrior : Character
{
    private int armor;
    
    public Warrior(string name, int health, int damage, int armor)
        : base(name, health, damage)
    {
        this.armor = armor;
    }
    
    // TODO 4: Добавьте override
    public /* override */ void Attack()
    {
        Console.WriteLine($"⚔️ {name} рубит мечом за {damage} урона!");
    }
    
    // TODO 5: Добавьте override
    public /* override */ void TakeDamage(int incomingDamage)
    {
        int actualDamage = incomingDamage - armor;
        if (actualDamage < 0) actualDamage = 0;
        health -= actualDamage;
        if (health < 0) health = 0;
        Console.WriteLine($"🛡️ {name} блокировал {armor}! HP: {health}/{maxHealth}");
    }
    
    // TODO 6: Добавьте override
    public /* override */ void ShowStatus()
    {
        string status = IsAlive() ? "💚" : "💀";
        Console.WriteLine($"[⚔️ ВОИН] {name} | HP: {health}/{maxHealth} | Броня: {armor} | {status}");
    }
}

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
    
    // TODO 7: Добавьте override
    public /* override */ void Attack()
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
    
    // TODO 8: Добавьте override
    public /* override */ void ShowStatus()
    {
        string status = IsAlive() ? "💚" : "💀";
        Console.WriteLine($"[🔮 МАГ] {name} | HP: {health}/{maxHealth} | Мана: {mana}/{maxMana} | {status}");
    }
}

class Archer : Character
{
    private int arrows;
    
    public Archer(string name, int health, int damage, int arrows)
        : base(name, health, damage)
    {
        this.arrows = arrows;
    }
    
    // TODO 9: Добавьте override
    public /* override */ void Attack()
    {
        if (arrows > 0)
        {
            Console.WriteLine($"🏹 {name} стреляет за {damage} урона!");
            arrows--;
        }
        else
        {
            Console.WriteLine($"📦 У {name} нет стрел!");
        }
    }
    
    // TODO 10: Добавьте override
    public /* override */ void ShowStatus()
    {
        string status = IsAlive() ? "💚" : "💀";
        Console.WriteLine($"[🏹 ЛУЧНИК] {name} | HP: {health}/{maxHealth} | Стрелы: {arrows} | {status}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║    🎮 ПРАКТИКА: ПОЛИМОРФИЗМ 🎮        ║");
        Console.WriteLine("╚════════════════════════════════════════╝\n");
        
        // TODO 11: Создайте массив Character[] с тремя героями
        // Подсказка: Character[] heroes = new Character[] { ... };
        Character[] heroes = new Character[]
        {
            // Ваш код здесь (создайте трёх героев):
            
            
            
        };
        
        Console.WriteLine("=== 📋 Команда ===\n");
        
        // TODO 12: В цикле выведите статус каждого героя
        // Подсказка: foreach (Character hero in heroes) { ... }
        
        
        
        
        Console.WriteLine("\n=== ⚔️ Все атакуют! ===\n");
        
        // TODO 13: В цикле каждый герой атакует
        
        
        
        
        Console.WriteLine("\n=== 🐉 Дракон атакует! ===\n");
        
        // TODO 14: В цикле каждый герой получает 50 урона
        
        
        
        
        Console.WriteLine("\n=== 📊 Сколько выжило? ===\n");
        
        // TODO 15: Посчитайте количество живых героев
        int alive = 0;
        
        
        
        
        Console.WriteLine($"🎯 Выжило: {alive}/{heroes.Length} героев");
        
        Console.WriteLine("\n" + "=".PadRight(50, '='));
        Console.WriteLine("💡 МАГИЯ ПОЛИМОРФИЗМА:");
        Console.WriteLine("   Один цикл → все герои");
        Console.WriteLine("   Один метод Attack() → разные реализации");
        Console.WriteLine("   Компилятор сам понимает, что вызывать!");
        Console.WriteLine("=".PadRight(50, '='));
    }
}
