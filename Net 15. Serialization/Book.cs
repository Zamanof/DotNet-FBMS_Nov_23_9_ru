﻿namespace Net_15._Serialization;
[Serializable]
public class Book
{
    [NonSerialized]
    public Guid Id;
    public Author? Author {  get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public Book()
    {
        Id = Guid.NewGuid();
    }
    public override string ToString()
    {
        return $@"Id = {Id}
Title: {Title}
Author: {Author}";
    }
}
