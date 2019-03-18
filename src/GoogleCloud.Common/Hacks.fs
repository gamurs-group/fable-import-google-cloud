namespace rec Fable.Import.GoogleCloud.Common

/// <summary>
///     Single-value tuple (aka womple).  Used as a workaround to represent single value tuples in Typescript.
/// </summary>
/// <remarks>
///     Many Google Cloud API endpoints return single element tuples (womples), for which no equivalent type exists in F#.
///     This type can be used to represent such types.  It's more palatable than the alternative, which is modelling such
///     types as arrays (Typescript tuples are implemented as arrays in Javascript)
///     and then indexing into them to get the value.
///
///     See: https://github.com/fable-compiler/ts2fable/issues/296
/// </remarks>
type Tuple1<'a> = 'a * unit

module Tuple1 =
    /// Unbox the single element of a Tuple1.
    let unbox (t1 : Tuple1<'a>) : 'a =
        let (v, _) = t1
        v

