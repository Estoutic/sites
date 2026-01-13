using System;

// ============================================
// ПРАКТИКА: Инкапсуляция
// Задание: Создать класс Mage
// Время: 10 минут
// ============================================

// Готовый класс Warrior (для примера)
class Warrior
{
    private string name;
    private int health;
    private int maxHealth;
    private int damage;
    private int armor;
    
    public Warrior(string name, int health, int damage, int armor)
    {
        this.name = name;
        this.health = health;
        this.maxHealth = health;
        this.damage = damage;
        this.armor = armor;
    }
    
    public void Attack()
    {
        Console.WriteLine($"⚔️ {name} бьёт мечом за {damage} урона!");
    }
    
    public void TakeDamage(int incomingDamage)
    {
        int actualDamage = incomingDamage - armor;
        if (actualDamage < 0) actualDamage = 0;
        health -= actualDamage;
        if (health < 0) health = 0;
        Console.WriteLine($"🛡️ {name} блокировал {armor}! Получил {actualDamage}. HP: {health}/{maxHealth}");
    }
    
    public bool IsAlive() => health > 0;
    
    public void ShowStatus()
    {
        string status = IsAlive() ? "💚" : "💀";
        Console.WriteLine($"[⚔️ ВОИН] {name} | HP: {health}/{maxHealth} | {status}");
    }
}

// TODO 1: Создайте класс Mage
class Mage
{
    // TODO 2: Объявите поля (private)
    // Нужны: name, health, maxHealth, damage, mana, maxMana
    
    
    
    
    
    // TODO 3: Создайте конструктор
    // Подсказка: похож на Warrior, но принимает mana вместо armor
    public Mage(string name, int health, int damage, int mana)
    {
        // Ваш код здесь:
        
        
        
    }
    
    // TODO 4: Метод Attack
    // Подсказка: Если mana >= 20, кастует заклинание и тратит 20 маны
    //            Иначе выводит "Нет маны!"
    public void Attack()
    {
        // Ваш код здесь:
        
        
        
        
    }
    
    // TODO 5: Метод TakeDamage
    // Подсказка: Уменьшает health на incomingDamage (без брони, т.к. маг хрупкий)
    public void TakeDamage(int incomingDamage)
    {
        // Ваш код здесь:
        
        
        
    }
    
    // TODO 6: Метод IsAlive
    // Подсказка: Возвращает true, если health > 0
    public bool IsAlive()
    {
        // Ваш код здесь:
        
    }
    
    // TODO 7: Метод ShowStatus
    // Подсказка: Выводит [🔮 МАГ] имя | HP: x/y | Мана: z/w
    public void ShowStatus()
    {
        // Ваш код здесь:
        
    }
}

// ТЕСТИРОВАНИЕ (не трогать)
class Program
{
    static void Main()
    {
        Console.WriteLine("=== ТЕСТ ИНКАПСУЛЯЦИИ ===\n");
        
        Warrior warrior = new Warrior("Конан", 150, 30, 20);
        Mage mage = new Mage("Гендальф", 80, 50, 100);
        
        warrior.ShowStatus();
        mage.ShowStatus();
        
        Console.WriteLine("\n--- Атаки ---");
        warrior.Attack();
        mage.Attack();
        
        Console.WriteLine("\n--- Получение урона ---");
        warrior.TakeDamage(40);
        mage.TakeDamage(40);
        
        Console.WriteLine("\n--- Финальный статус ---");
        warrior.ShowStatus();
        mage.ShowStatus();
        
        Console.WriteLine("\n✅ Если всё работает - вы молодец!");
    }
}