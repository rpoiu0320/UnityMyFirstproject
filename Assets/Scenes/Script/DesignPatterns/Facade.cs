using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//========================================
//##		������ ���� Facade			##
//========================================
/*
	�ۻ�� ���� :
	Ŀ�ٶ� �ڵ� �κп� ���� ����ȭ�� �������̽��� �����ϴ� ������ ������ ����
	�ۻ�� ��ü�� ������ ����Ʈ���� �ٱ����� �ڵ尡 ���̺귯���� ���� �ڵ忡 �����ϴ� ���� ����
	������ ������ �����ϰ� ������ �� �ִ� �������̽��� ����

	���� :
	1. Facade Ŭ������ Subsystem Ŭ�������� ȥ���Ͽ� Client�� ��û�� �� �ִ� ������ �Լ��� ����

	���� :
	1. Subsystem ���� ���յ��� ����
	2. Client ���忡�� ���� ������ �ڵ�� ������ �� ����

	���� :
	1. Client���� ���� Subsystem���� ���� �� ����
	2. Client�� Subsystem ������ Ŭ������ ���� ����ϴ� ���� ���� �� ����
*/


// Client
public class User
{
    public void WorkStart()
    {
        Computer computer = new Computer();
        computer.TurnOn();
    }
}

// Facade
public class Computer
{
    public void TurnOn()
    {
        CPU cpu = new CPU();
        Memory memory = new Memory();
        Mainboard board = new Mainboard();

        byte[] bootloadData = board.BootLoad();
        memory.Save(bootloadData);
        cpu.Excute(memory.Load());
        byte[] biosData = board.Bios();
        memory.Save(biosData);
        cpu.Excute(memory.Load());
    }
}

// Subsystems
public class CPU
{
    public void Excute(byte[] data) { }
}

public class Mainboard
{
    private byte[] bootloadData;
    private byte[] biosData;

    public byte[] BootLoad() { return bootloadData; }
    public byte[] Bios() { return biosData; }
}

public class Memory
{
    private byte[] memory;

    public void Save(byte[] data) { }
    public byte[] Load() { return memory; }
}