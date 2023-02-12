using Ballers_API.Models;
using Microsoft.AspNetCore.Mvc;


[Route("api/pitchAPI")]
public class PitchController : Controller
{

    private readonly AppDbContext db;

    public PitchController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<PitchDTO>> GetPitches()
    {
        return Ok(db.Pitches.ToList());
    }

    [HttpGet("{id:int}", Name = "GetPitch")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<PitchDTO> GetPitch(int id)
    {
        if (id < 1)
            return BadRequest();

        var pitch = db.Pitches.FirstOrDefault(u => u.Id == id);
        if (pitch == null) { return NotFound(); }
        return Ok(pitch);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<PitchDTO> CreatePitch([FromBody] Pitch pitch)
    {
        if (pitch == null)
            Console.WriteLine("Pitch is Null");
            return BadRequest(pitch);
        if (pitch.Id > 0)
            return BadRequest(pitch);

        db.Pitches.Add(pitch);
        db.SaveChanges();
        return CreatedAtRoute("GetPitch", new { id = pitch.Id }, pitch);
    }

    [HttpDelete("{id:int}", Name = "DeletePitch")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult DeletePitch(int id)
    {
        if (id < 1)
            return BadRequest();
        var pitch = db.Pitches.FirstOrDefault(u => u.Id == id);
        if (pitch == null) { return NotFound(); }
        db.Pitches.Remove(pitch);
        return NoContent();
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult UpdatePitch(int id, [FromBody] Pitch pitch)
    {
        if (pitch == null || id != pitch.Id) return BadRequest();
        db.Pitches.Update(pitch);
        db.SaveChanges();
        return NoContent();
    }
}
